#ifndef BINDING_H
#define BINDING_H

#include <iostream>
#include <string>
#include "selene.h"

class Binding
{
public:
	Binding();
	Binding(std::string _path);
	~Binding();
	void update();
	void setPath(std::string _path);
	sel::State &getLuaState();

private:
	sel::State state{ true };
	std::string path;
};

#endif
