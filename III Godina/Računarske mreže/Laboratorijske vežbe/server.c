#include <iostream>
#include <string>
#include <winsock.h>
#pragma comment(lib, "wsock32.lib")

#define SERVER_PORT 8888
#define BUF_SIZE 1024

// Funkcija za ispisivanje greške i izlaz iz programa
void ExitWithError(const char* errorMessage) {
    std::cerr << errorMessage << std::endl;
    WSACleanup();
    exit(EXIT_FAILURE);
}

int main() {
    WSAData wsa;
    SOCKET serverSock;

    // Inicijalizacija Winsock-a
    if (WSAStartup(0x0202, &wsa) != 0) {
        ExitWithError("WSAStartup failed.");
    }

    // Kreiranje socket-a
    if ((serverSock = socket(AF_INET, SOCK_DGRAM, 0)) == INVALID_SOCKET) {
        ExitWithError("Error creating socket.");
    }

    sockaddr_in server;
    server.sin_family = AF_INET;
    server.sin_addr.s_addr = INADDR_ANY;
    server.sin_port = htons(SERVER_PORT);

    // Povezivanje socket-a sa adresom
    if (bind(serverSock, (struct sockaddr*)&server, sizeof(server)) == SOCKET_ERROR) {
        ExitWithError("bind() failed.");
    }

    sockaddr_in client;
    int addrlen = sizeof(sockaddr);

    while (true) {
        char echoBuf[BUF_SIZE];
        int recvMsgSize = recvfrom(serverSock, echoBuf, BUF_SIZE, 0, (struct sockaddr*)&client, &addrlen);

        if (recvMsgSize == SOCKET_ERROR) {
            ExitWithError("recv() failed.");
        }

        // Dodaj NULL terminator kako bi ispravno prikazao string
        echoBuf[recvMsgSize] = '\0';

        std::cout << "Received message from client: " << echoBuf << std::endl;

        // Slanje poruke nazad klijentu
        if (sendto(serverSock, echoBuf, recvMsgSize, 0, (struct sockaddr*)&client, sizeof(sockaddr)) == SOCKET_ERROR) {
            ExitWithError("sendto() failed.");
        }
    }

    // Zatvaranje socket-a
    closesocket(serverSock);
    WSACleanup();

    return 0;
}
