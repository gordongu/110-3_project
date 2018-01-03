#ifndef ENTITY_H
#define ENTITY_H

#include <iostream>
#include "selene.h"

class Entity
{
public:
	Entity();
	Entity(std::string _type);
	~Entity();

	void update();

	std::string get_type();
	int get_x();
	int get_y();

	void set_type(std::string _type);
	void set_x(int _x);
	void set_y(int _y);

	void setLuaState(sel::State *_state);

private:
	std::string type;
	int x;
	int y;

	sel::State *state;
};

#endif
