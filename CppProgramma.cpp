#include <iostream>
#include <fstream>
using namespace std;
int main(){
	ifstream dati1;
    ofstream dati2;
    dati1.open("saspiests_teksts.txt",ios::in);
    dati2.open("sakotnejais_tekstins.txt",ios::out);
    char s1,s2,s3,s4;
    int sk, i;
    dati1.get(s1); //nolasa 1. simbolu
    while(!dati1.eof()){  //kamer datne nav nolasita lidz beigam
        dati1.get(s2); //nolasa nakamo simb.  
		if(s1!=s2){ //ja simb.nav vienadi
			dati2<<s1;
			s1=s2;  //simbolu, kurs jau uzrakstits aizstaj ar nakamo simbolu
		}             
        else if(!dati1.eof()){ //kamer divi blakus esoši simboli ir vienadi
                               //un nav sasniegtas datnes beigas
            	dati1.get(s3); //nolasa nakamo simb.
            	dati1.get(s4); //nolasa nak. simb.
        		if(s4>='0' && s4<='9'){
					sk=(s3-48)*10+(s4-48); // ja simb.>1 
				}else{
					sk=(s3-48);
				}    
				for(i=0; i<sk; i++){
					dati2<<s1;
				}	
				if(sk>=10) {
					dati1.get(s1); //nolasa nak. simb.
				}else{
					s1=s4;
				}					
		}
    }
	dati2<<s2;//izdruka pedejo simb.
    dati1.close();
    dati2.close();
    return 0;
}
