#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <sys/file.h>
#include <sys/dirent.h>
#include <sys/stat.h>
#include <sys/types.h>
#include <sys/fcntl.h>
char *apsolutnaPutanja;
struct datoteka
{
    double velicina;
    char ime[256]; // Zato sto u Linux OS, maksimalna duzina imena fajla 255 + '\0'
};
struct datoteka *nizFajlova;
uint startnaVelicina = 50;
nizFajlova = (struct datoteka *)malloc(sizeof(datoteka) * startnaVelicina);
uint fajloviCount = 0;
void obilazakDirektorijumaPodubini(DIR *dp)
{
    struct stat buff;
    struct dirent *dirp;
    DIR *d;
    char *putanjaPodfoldera;
    while (dirp = readdir(dp) != NULL)
    {
        if (S_ISDIR(buff.st_mode;)) // Da li je trenutni fajl direktorijum
        {
            strcpy(putanjaPodfoldera, apsolutnaPutanja);
            strcat(putanjaPodfoldera, dirp.d_name);
            d = opendir(putanjaPodfoldera);
            obilazakDirektorijumaPodubini(d);
        }
        if (S_ISREG(buff.st_mode) && buff.st_size >= 100000)
        { // ako jeste regularni fajl i ako jeste >= 100KB
            if (fajloviCount >= startnaVelicina)
            {
                if (startnaVelicina < 100)
                    startnaVelicina *= 3;
                else
                    startnaVelicina *= 2;

                struct datoteka *pom = (struct datoteka *)realloc(nizFajlova, sizeof(datoteka) * startnaVelicina);
                if (pom != NULL)
                    nizFajlova = pom;
                pom = NULL;
            }
            nizFajlova[fajloviCount].velicina = buff.st_size;
            strcpy(nizFajlova[fajloviCount].ime, buff.st)
        }
    }
}
void sortirajPoVeliciniRastuci()
{
    struct datoteka pomDat;

    for (int i = 0; i < fajloviCount - 1; i++)
    {
        if (nizFajlova[i] < nizFajlova[i + 1])
        {
            pomDat = nizFajlova[i];
            nizFajlova[i] = nizFajlova[i + 1];
            nizFajlova[i + 1] = pomDat;
        }
    }
}
int main(int argc, char *argv[])
{
    // Preuzmi apsolutnu putanju
    strcpy(apsolutnaPutanja, argv[2]);
    // Procitati sadrzaj direktorijuma
    struct dirent *dirp;
    DIR *d;
    d = opendir(apsolutnaPutanja);
    obilazakDirektorijumaPodubini(d);
    sortirajPoVeliciniRastuci();
    for (int i = 0; i < fajloviCount; i++)
    {
        printf("%d %s \n", nizFajlova[i].velicina, nizFajlova[i].ime);
    }

    return 0;
}