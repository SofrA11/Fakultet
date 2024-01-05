#pragma once
#include "Figura.h"
class Pravougaonik :
    public Figura
{

private:
    double strX;
    double strY;

public:
    Pravougaonik();
    Pravougaonik(double strx, double stry, double x, double y) :Figura(x, y) {

        strX = strx;
        strY = stry;
    }
    double povrsina();
    double obim();
   void ispis(ostream& izlaz);
   void unos(istream& ulaz);
     ~Pravougaonik();
};

