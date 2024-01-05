#include "Kvadrat.h"
#include<fstream>
Kvadrat::Kvadrat()
{
	stranica = 0;
}
double Kvadrat::povrsina()
{
	return stranica*stranica;
}
double Kvadrat::obim()
{
	return 4*stranica;
}
void Kvadrat::ispis(ostream& izlaz)
{
	izlaz << stranica <<endl<< getX() << endl <<getY() << endl;
}

void Kvadrat::unos(istream& ulaz)
{
	ulaz >> stranica;
}

Kvadrat::~Kvadrat()
{
	
}
