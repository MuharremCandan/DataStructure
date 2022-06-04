namespace DataStructure
{
    public class CiftYönlüListe
    {
        Node? head;
        Node? tail;

        public CiftYönlüListe()
        {
            this.head = null;
            this.tail = null;
        }
        public void basaEkle(int data){

            Node eleman = new Node(data);

            if(head == null){
                head = tail = eleman;
                System.Console.WriteLine("İlk eleman eklendi !");
            }else{
               eleman.next = head;
               head.prev = eleman;
               head = eleman;
               System.Console.WriteLine("Listenin başına elaman eklendi !");              
            }

        }
        public void sonaEkle(int data){

            Node eleman = new Node(data);

            if(head == null){
                head = tail = eleman;
                System.Console.WriteLine("İlk eleman eklendi !");
            }else{
                tail.next = eleman;
                eleman.prev = tail;
                tail = eleman;
                System.Console.WriteLine("Listenin sonuna elaman eklendi !");              
            }

        }

        public void arayaEkle(int indis, int data){
            Node eleman = new Node(data);
            bool sonuc = false;
 
            if(head == null && indis == 0){
                sonuc = true;         
                head = tail = eleman;
                System.Console.WriteLine("ilk elaman eklendi !");
            }
            else if (head != null && indis == 0){
                basaEkle(data);
            }
            else{
                int i = 0;
                Node temp = head;
                Node temp2 = temp;                
                while(temp.next != null){

                    temp2 = temp;
                    temp = temp.next;
                    i++;
                    if(i == indis){
                        
                        sonuc = true;
                        temp2.next = eleman;
                        eleman.prev = temp2;
                        eleman.next = temp;
                        temp.prev = eleman;
                        System.Console.WriteLine("araya eklendi !");
                        i++;
                        break;
                    }
                   
                }
                if ((i) == indis){
                    sonuc = true;
                    sonaEkle(data);

                    System.Console.WriteLine("sona eleamn eklendi !");
                }           
            }
            if(sonuc == false ){
                System.Console.WriteLine("Hatalı indis numarası !");
            }
        }

        public void bastanSil(){
            if(head == null){
                System.Console.WriteLine("Liste boş !");
            }
            else if(head.next == null){
                head = tail = null;
                System.Console.WriteLine("Listede kalan son düğüm silindi !");
            }
            else{
                head = head.next;
                head.prev= null;
                System.Console.WriteLine("Baştan silme işlemi başarılı !");
            }
        }

        public void sondanSil(){
              if(head == null){
                System.Console.WriteLine("Liste boş !");
            } else if(head.next == null){
                head = tail = null;
                System.Console.WriteLine("Listede kalan son düğüm silindi !");
            }
            else{
                tail = tail.prev;
                tail.next = null;
                System.Console.WriteLine("Sondan silme işlemi başarılı bir şekilde gerçekleştirlidi!");
            }
        }

        public void aradanSilme(int indis){

            bool sonuc = false;

            if(head == null){
                System.Console.WriteLine("Liste bomboş !");
            }
            else if(head.next == null && indis == 0){
                sonuc= true;
                head = tail = null;
                System.Console.WriteLine("Son eleman silindi !");
            }
            else if(head.next != null && indis == 0){
                sonuc = true;
                bastanSil();
            }
            else{

                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while(temp.next != null){
                    
                    if(i == indis){
                        sonuc = true;
                        temp2.next = temp.next;
                        temp.next.prev = temp2;
                        System.Console.WriteLine("Aradan silme işlemi başarılı !");
                        i++;
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
            if(sonuc == false){
                System.Console.WriteLine("Geçersiz işlem!");
            }
        }
        public void ekranaYaz(){

            if (head == null){
            System.Console.WriteLine("Liste bomboş !");
            }else{
                 Node? temp= head;
                System.Console.Write("\nbas -> ");
                while(temp.next != null){
                    System.Console.Write(temp.data+ "-> ");
                    temp = temp.next;                
                } 
                System.Console.WriteLine(temp.data+ " son.");
           } 
        }
        
    }
}