#include <iostream>
#include <stdio.h>
#include "Binding.h"
#include "Entity.h"

Binding binding;
Entity entity;

int main(int argc, char* argv[])
{
	std::string temp;

	binding.setPath("./Scripts/main.lua");
	//binding.update();
	entity.setLuaState(&binding.getLuaState());
	entity.update();

	std::cin >> temp;

	return 0;
}