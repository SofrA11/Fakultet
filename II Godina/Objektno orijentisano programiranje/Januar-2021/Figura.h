#pragma once
#include<iostream>
#include<fstream>
using namespace std;
class Figura
{
private:
	double x;
	double y;
public:
	Figura();
	Figura(double,double);
	virtual void unos(istream&)=0;
	virtual void ispis(ostream&)=0;
	double getX();
	double getY();
	virtual double povrsina()=0;
	virtual double obim() = 0;


	friend ostream& operator<<(ostream& izlaz,Figura& F);
	friend istream& operator>>(istream& ulaz, Figura& F);
	virtual ~Figura();
};

