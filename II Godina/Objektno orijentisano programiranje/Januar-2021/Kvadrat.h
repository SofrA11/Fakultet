#pragma once
#include "Figura.h"
class Kvadrat :
    public Figura
{
private:
    double stranica;
public:
    Kvadrat();
    Kvadrat(double str, double x, double y) :Figura(x, y)
    {
        stranica = str;
    }
    ~Kvadrat();

    double povrsina();
    double obim();
     void ispis(ostream& izlaz);
     void unos(istream& ulaz);
 
};

