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

	return 0;
}