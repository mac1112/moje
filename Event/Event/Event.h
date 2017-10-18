#pragma once
#include <iostream>
#include <string>

using namespace std;

class Event
{
	string name;
	int year, month, day, hour, minutes;
	
public:
	Event(string="brak", int=1, int=1, int=2002, int=13 ,int=14);
	~Event();
	void load();
	void show();
};

