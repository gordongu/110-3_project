#include "Binding.h"

Binding::Binding()
{

}

Binding::Binding(std::string _path)
{
	path = _path;

	if (! state.Load(path))
	{
		printf("Error: File path does not exist.");
	}
}

Binding::~Binding()
{

}

void Binding::update()
{
	std::string temp = state["main"]();

	std::cout << temp << std::endl;
}

void Binding::setPath(std::string _path)
{
	path = _path;

	if (! state.Load(path))
	{
		printf("Error: File path does not exist.");
	}
}

sel::State &Binding::getLuaState()
{
	return state;
}
