#include <stdio.h>


int main(){
	int leet = 1337;
	int counter = 2;
	int first_serial, second_serial, tmp;
	
	printf("Masukkan angka untuk first serial (bebas): ");
	scanf("%d", &second_serial);
	tmp = second_serial;
	
	while(leet) {
		second_serial = second_serial ^ counter;
		++counter;
		--leet;
	}
	first_serial = second_serial;
	second_serial = tmp;
	
	printf("First serial: %d \nsecond serial: %d\n", first_serial, tmp);
	
	return 0;
}