#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>
#include <stdbool.h>
#define min 0
#define max 100

int main() {

	int guess,guesses,number;
	bool playAgain = true;
	char response;

	while (playAgain)
	{
		printf("Enter a number: ");
		scanf("%d",&guess);

		srand(time(0));
		number = (rand() % max) + min;

		while (guess != number)
		{
			if (guess>number)
			{
				printf("%d is high!\n",guess);
				printf("Enter lower number: ");
				scanf("%d",&guess);
			}
			else if (guess<number)
			{
				printf("%d is low!\n",guess);
				printf("Enter higher number: ");
				scanf("%d",&guess);
			}
		}
		if (guess == number)
		{
			printf("You WON!\n");
		}
		
		printf("Would you like to play again?(Y/N)\n");
		scanf(" %c", &response);
			
		if (response == 'y' || response == 'Y')
		{
			playAgain = 1;
		}
		else if(response == 'n' || response == 'N')
		{
			playAgain = 0;
		}
		
	}
	
	getch();
	return 0;
}