#pragma once
class Application
{
public:
	virtual void Load();
	virtual void Update(float _deltaTime);
	virtual void Draw();
	virtual void Unload();

private:
	

};
