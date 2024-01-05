#include "Kolekcija.h"

Kolekcija::Kolekcija()
{
    Fig = nullptr;
    maxFig = 0;
    trenFig = 0;
}

Kolekcija::Kolekcija(int n)
{
    maxFig = n;
    Fig = new Figura * [n];
    trenFig = 0;
}

Kolekcija::~Kolekcija()
{
    if (Fig != nullptr)
    {
        delete[] Fig;
        Fig = nullptr;
    }
}

int Kolekcija::DodajElement(Figura* F)
{
    if (trenFig == maxFig)
         maxFig+=(maxFig/2);
        Fig[trenFig] = F;
        trenFig++;
        return 1;
}

double Kolekcija::Povrsina()
{
    double P=0;
    for (int i = 0;i < trenFig + 1;i++)
        P+=Fig[i]->povrsina();
    return P;
}

double Kolekcija::Obim()
{
    double O = 0;
    for (int i = 0;i < trenFig + 1;i++)
        O += Fig[i]->obim();
    return O;
}

void Kolekcija::OSortRastuce()
{
    Figura* pom;
    for (int j = 0;j < trenFig;j++)
        for (int i = 0;i < trenFig-1;i++)
        {
            if (Fig[i]->obim() > Fig[i + 1]->obim())
            {
                pom = Fig[i];
                Fig[i] = Fig[i+1];
                Fig[i + 1] = pom;
            }
        }
    
}

void Kolekcija::OSortOpadajuce()
{
    Figura* pom;
    for (int j = 0;j < trenFig;j++)
        for (int i = 0;i < trenFig - 1;i++)
        {
            if (Fig[i]->obim() < Fig[i + 1]->obim())
            {
                pom = Fig[i];
                Fig[i] = Fig[i + 1];
                Fig[i + 1] = pom;
            }
        }
}

ostream& operator<<(ostream& out, Kolekcija& k)
{
    for (int i = 0;i < k.trenFig;i++)
        out << *k.Fig[i] << endl;
    return out;
}
