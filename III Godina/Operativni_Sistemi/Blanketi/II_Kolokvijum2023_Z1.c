#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/ipc.h>
#include <sys/msg.h>

#define MAX_PORUKA 10
struct poruka
{
    int prioritet;
    int broj;
};

int main(int atgc, char *argv[])
{
    int pid;
    int redid;
    struct poruka buffer;
    pid = fork();
    int suma1 = 0;
    int suma2 = 0;
    int suma3 = 0;
    redid = msgget(10001, IPC_CREAT | 0666);
    if (pid < 0)
        printf("Greska");

    if (pid == 0)
    {
        printf("Process Dete\n");
        while (suma1 + suma2 + suma3 < 50000)
        {
            msgrcv(redid, &buffer, MAX_PORUKA, 0, 0);
            int prioritet = buffer.prioritet;
            int broj = buffer.broj;
            if (prioritet == 1)
                suma1 += broj;
            else if (prioritet == 2)
                suma2 += broj;
            else if (prioritet == 3)
                suma3 += broj;
        }

        if (suma1 + suma2 + suma3 >= 50000)
        {
            buffer.broj = -1;
            buffer.prioritet = 0;
            msgsnd(redid, &buffer, 2, 0);
        }
        printf("Suma 1 = %d \n Suma 2 = %d \n Suma 3= %d \n", suma1, suma2, suma3);
        printf("Ukupna suma je : %d \n", suma1 + suma2 + suma3);
        exit(1);
    }
    else
    {
        printf("Process\n");
        while (1)
        {

            int number = rand() % 1000;
            int prioritet;
            if (number < 10)
            {
                prioritet = 1;
            }
            else
            {
                if (number < 100)
                {
                    prioritet = 2;
                }
                else
                {
                    prioritet = 3;
                }
            }
            buffer.prioritet = prioritet;
            buffer.broj = number;
            msgsnd(redid, &buffer, MAX_PORUKA, 0);
            msgrcv(redid, &buffer, MAX_PORUKA, 0, IPC_NOWAIT);
            if (buffer.broj == -1)
            {
                break;
            }
        }
        msgctl(redid, IPC_RMID, NULL);
    }
    return 0;
}