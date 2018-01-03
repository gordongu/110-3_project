#include "Entity.h"

Entity::Entity()
{
	type = "";
}

Entity::Entity(std::string _type)
{
	type = _type;
}

Entity::~Entity()
{

}

void Entity::update()
{
	std::string temp = (*state)["main"]();

	std::cout << temp << std::endl;
}

std::string Entity::get_type()
{
	return type;
}

int Entity::get_x()
{
	return x;
}

int Entity::get_y()
{
	return y;
}

void Entity::set_type(std::string _type)
{
	type = _type;
}

void Entity::set_x(int _x)
{
	x = _x;
}

void Entity::set_y(int _y)
{
	y = _y;
}

void Entity::setLuaState(sel::State *_state)
{
	state = _state;
}
