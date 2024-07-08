#include <iostream>
#include <enet/enet.h>

int main(int argc, const char* argv)
{
	if (enet_initialize() != 0)
	{
		fprintf(stderr, "An error occured while initializing ENet.\n");
		return EXIT_FAILURE;
	}
	atexit(enet_deinitialize);

	ENetHost* client;
	client = enet_host_create(NULL, 1, 1, 0, 0);

	if (client == NULL)
	{
		fprintf(stderr, "An error occured while trying to create an ENet client host.\n");
		return EXIT_FAILURE;
	}

	ENetAddress address;
	ENetEvent event;
	ENetPeer* peer;

	enet_address_set_host(&address, "192.168.0.51");
	address.port = 7777;

	peer = enet_host_connect(client, &address, 1, 0);
	if (peer == NULL)
	{
		fprintf(stderr, "No available peers for initiating an ENet connection.");
		return EXIT_FAILURE;
	}

	if (enet_host_service(client, &event, 5000) > 0 && event.type == ENET_EVENT_TYPE_CONNECT)
		puts("Connection to 192.168.0.51:7777 succeeded.\n");

	else
	{
		enet_peer_reset(peer);
		puts("Connection to 192.168.0.51:7777 failed.");

		return EXIT_SUCCESS;
	}

	// GAME LOOP START

	// Wait up to 1000 milliseconds for an event
	while (enet_host_service(client, &event, 1000) > 0)
	{
		switch (event.type)
		{
		case ENET_EVENT_TYPE_RECEIVE:
			printf("A packet of length %u containing %s was recieved from %x:%u on channel %u.\n",
				event.packet->dataLength,
				event.packet->data,
				event.peer->address.host,
				event.peer->address.port,
				event.channelID);
			break;
		}
	}

	// GAME LOOP END

	enet_peer_disconnect(peer, 0);

	while (enet_host_service(client, &event, 3000) > 0)
	{
		switch (event.type)
		{
		case ENET_EVENT_TYPE_RECEIVE:
			enet_packet_destroy(event.packet);
			break;

		case ENET_EVENT_TYPE_DISCONNECT:
			puts("Disconnection succeeded.");
		}
	}

	return EXIT_SUCCESS;
}