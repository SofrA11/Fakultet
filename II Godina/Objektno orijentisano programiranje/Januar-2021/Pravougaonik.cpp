#include "Pravougaonik.h"
#include<fstream>
Pravougaonik::Pravougaonik()
{
	strX = 0;
	strY = 0;
}

void Pravougaonik::ispis(ostream& izlaz)
{
	izlaz << strX << endl << strY << endl << getX() << endl << getY() << endl;
}

void Pravougaonik::unos(istream& ulaz)
{
//	ifstream ulaz("Pravougaonik Unos.txt");
	ulaz >> strX >> strY;
}

double Pravougaonik::povrsina()
{
	return strX*strY;
}

double Pravougaonik::obim()
{
	return 2*strX+2*strY;
}

Pravougaonik::~Pravougaonik()
{
}