namespace DataStructure
{
    public class CiftYönlüDaireselListe
    {
        Node? head;
        Node? tail;

        public CiftYönlüDaireselListe()
        {
            head = null;
            tail = null;
            
        }

        public void basaEkle(int data){
            Node eleman = new Node(data);
            if(head == null ){
               head = tail = eleman;

               tail.next = head;
               tail.prev = head;
               head.next = tail;
               head.prev = tail;
               System.Console.WriteLine("ilk eleman eklendi !");
            }else {
                
                eleman.next = head;
                head.prev = eleman;
                head = eleman;

                head.prev = tail;
                tail.next = head;
                System.Console.WriteLine("başa eleman eklendi !");
            }
             

        }
         public void sonaEkle(int data){
            Node eleman = new Node(data);
            if(head == null ){
               head = tail = eleman;

               tail.next = head;
               tail.prev = head;
               head.next = tail;
               head.prev = tail;
               System.Console.WriteLine("ilk eleman eklendi !");
            }else {

                tail.next = eleman;
                eleman.prev = tail;
                tail = eleman;
                tail.next = head;
                head.prev = tail;
                System.Console.WriteLine("sona eleman eklendi !");
            }
            
        }

        public void arayaEkle(int indis, int data){
             Node eleman = new Node(data);
             bool sonuc = false;

            if(head == null && indis == 0){
               head = tail = eleman;

               tail.next = head;
               tail.prev = head;
               head.next = tail;
               head.prev = tail;
               sonuc = true;
               System.Console.WriteLine("ilk eleman eklendi !");
            } else if (head != null && indis == 0){
                basaEkle(data);
                sonuc = true;
            }
            else {

                Node temp = head;
                Node temp2 = temp;
                int i =0;
                while(temp != tail){
                  
                    if( i == indis){
                        temp2 .next = eleman;
                        eleman.prev = temp2;
                        eleman.next = temp;
                        temp.prev= eleman;
                        i++;
                        sonuc = true;
                        System.Console.WriteLine("araya eleman eklendi !");
                        break;

                    }   
                    temp2 = temp;
                    temp = temp.next;
                    i++;

                }
                if (i == indis){
                      sonaEkle(data);
                    sonuc = true;
                } 
                if(sonuc == false ){
                        System.Console.WriteLine("geçersiz işlem !");
                }
            }

        }

        public void bastanSil(){
            if(head == null){
                System.Console.WriteLine("liste boş !");
            }else if (head.next == head){
                head = tail = null;
                System.Console.WriteLine("listedeki son eleamn silindi !");
            }else{
                head = head.next;
                head.prev= tail;
                tail.next= head;
                System.Console.WriteLine("baştan eleman silindi !");
            }

        }
        public void sondanSil(){
           if(head == null){
                System.Console.WriteLine("liste boş !");
            }else if (head.next == head){
                head = tail = null;
                System.Console.WriteLine("listedeki son eleamn silindi !");
            }else{
               tail = tail.prev ;
               tail.next = head;
               head.prev = tail;
                System.Console.WriteLine("baştan eleman silindi !");
            }   

        }

        public void aradanSil(int indis){
             if(head == null){
                System.Console.WriteLine("liste boş !");
            }else if (head.next == head && indis == 0){
                head = tail = null;
                System.Console.WriteLine("listedeki son eleamn silindi !");
            }else if (head != null  && indis == 0){
                bastanSil();
            } 
            else{
                Node temp = head;
                Node temp2 = temp;
                int i = 0;

                while (temp != tail ){

                    if(i == indis){
                        temp2.next = temp.next;
                        temp.next.prev = temp2;
                        i++;

                        System.Console.WriteLine("aradan silme işlemi yapıldı !");
                        break;
                    }

                    temp2 = temp;
                    temp = temp.next;
                    i++;

                }
                if(i == indis){
                      sondanSil(); 
                }
              
            }   

        }

        public void ekranaYaz(){

            if(head == null){
                System.Console.WriteLine("Liste boş !");
            }else{
                Node temp = head;

                System.Console.Write("\nbaş -> ");
                while(temp != tail){
                    System.Console.Write(temp.data + " -> ");
                    temp= temp.next;
                }
                System.Console.Write(temp.data+" son.\n");
            
            }

        }
    }
}