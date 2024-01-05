#include "Figura.h"

Figura::Figura()
{
	x = 0;
	y = 0;
}

Figura::Figura(double a, double b)
{
	x = a;
	y = b;
}

double Figura::getX()
{
	return x;
}

double Figura::getY()
{
	return y;
}

ostream& operator<<(ostream& izlaz, Figura& F)
{
	F.ispis(izlaz);
	return izlaz; 
}

istream& operator>>(istream& ulaz, Figura& F)
{
	F.unos(ulaz);
	return ulaz;
}

Figura::~Figura()
{
	
}
