/*Korišćenjem programskog jezika C napisati Linux program koji za tekućei direktorijum generiše
statistiku tako što prebrojava: podfoldere, linkove, prazne regularne datoteke i regularne datoteke čija
je veličina veća od 0B. Na kraju program na ekranu štampa ovu statistiku (brojeve stavki po tipu).*/

#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <dirent.h>
#include <sys/types.h>
#include <linux/limits.h>
#include <sys/stat.h>
struct data *nizPodataka;
struct data
{
    int count;
    char tip[50]; // 0 podfolderi, 1 linkovi, 2 prazne regularne dat, 3 regularne datoteke koje nisu prazne
};

void Statistika(char *pth)
{

    DIR *dp;
    struct dirent *dirp;
    struct stat statbuffer;
    dp = opendir(pth);
    int len;
    while ((dirp = readdir(dp)) != NULL)
    {
        if (strcmp(dirp->d_name, ".") != 0 && strcmp(dirp->d_name, "..") != 0)
        {
            char *lokalnaPutanja = (char *)malloc(sizeof(char) * (strlen(pth) + strlen(dirp->d_name) + 2));
            strcpy(lokalnaPutanja, pth);
            strcat(lokalnaPutanja, "/");
            strcat(lokalnaPutanja, dirp->d_name);
            if (stat(lokalnaPutanja, &statbuffer) == -1)
            {
                printf("Lose\n");
                continue;
            }
            if (S_ISDIR(statbuffer.st_mode))
            {
                nizPodataka[0].count++;
                Statistika(lokalnaPutanja);
            }
            else if (S_ISLNK(statbuffer.st_mode))
            {
                nizPodataka[1].count++;
            }
            else if (S_ISREG(statbuffer.st_mode))
            {
                if (statbuffer.st_size == 0)
                {
                    nizPodataka[2].count++;
                }
                else
                {
                    nizPodataka[3].count++;
                }
            }
            free(lokalnaPutanja);
        }
    }
    return;
}
int main(int argc, char *argv[])
{
    nizPodataka = (struct data *)malloc(sizeof(struct data) * 4);
    int len = strlen(argv[1]);
    char *putanja = (char *)malloc(sizeof(char) * (len + 1));
    putanja[PATH_MAX - 1] = '\0';
    for (int i = 0; i < 4; i++)
    {
        nizPodataka[i].count = 0;
    }
    strcpy(nizPodataka[0].tip, "Direktorijum");
    strcpy(nizPodataka[1].tip, "Link");
    strcpy(nizPodataka[2].tip, "Prazan Fajl");
    strcpy(nizPodataka[3].tip, "Fajl");
    strcpy(putanja, argv[1]);
    Statistika(putanja);

    for (int i = 0; i < 4; i++)
    {
        printf("%s Count=%d \n", nizPodataka[i].tip, nizPodataka[i].count);
    }
    return 0;
}
