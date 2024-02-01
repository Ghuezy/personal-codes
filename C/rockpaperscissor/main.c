#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>

void checkGame(char player, char computer){

    if(player == computer){
        printf("Game is draw\n");
        printf("Player chose %c , Computer chose %c\n" , player, computer);
    } else if( player == 'p' && computer == 's'){
        printf("Computer won!\n");
        printf("Player chose %c , Computer chose %c\n" , player, computer);
    } else if( player == 'p' && computer == 'r'){
        printf("Player won!\n");
        printf("Player chose %c , Computer chose %c\n" , player, computer);
    } else if( player == 'r' && computer == 'p'){
        printf("Computer won!\n");
        printf("Player chose %c , Computer chose %c\n" , player, computer);
    } else if( player == 'r' && computer == 's'){
        printf("Player won!\n");
        printf("Player chose %c , Computer chose %c\n" , player, computer);
    } else if( player == 's' && computer == 'p'){
        printf("Player won!\n");
        printf("Player chose %c , Computer chose %c\n" , player, computer);
    } else if( player == 's' && computer == 'r'){
        printf("Computer won!\n");
        printf("Player chose %c , Computer chose %c\n" , player, computer);
    }

}

char handleInput(){
    char player;
    bool isValid = true;

    while (isValid){
        printf("\nPlayer enter your choice : ");
        scanf("%c",&player);
        getchar();
        printf("\n");

        if ( player == 'r' || player == 'p' || player == 's' || player == 'q')
            isValid = false;
        else
            isValid = true;
    }

    return player;
}

int main() {
    char player;
    char computer;
    int random;
    bool isOver = false;
    int result;

    printf("\n------------------Welcome to Rock Paper Scissor------------------\n");
    printf(">>>MOVES\n\n");
    printf("r - Rock \n");
    printf("p - Paper \n");
    printf("s - Scissor \n");
    printf("q - Quit \n");

    while (!isOver){


        srand(time(NULL));
        random = rand() % 3;

        switch (random) {
            case 0:
                computer = 'r';
                break;
            case 1:
                computer = 'p';
                break;
            case 2:
                computer = 's';
                break;
            default:
                break;
        }

        player = handleInput();

        if (player == 'q')
            isOver = true;

        checkGame(player,computer);
    }

    printf("THANKS FOR PLAYING");

    return 0;
}
