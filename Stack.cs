namespace DataStructure
{
    public class Stack
    {
        Node? top;
        public Stack()
        {
            top = null;     
        }
        public int pop(){
            if(top == null){
                System.Console.WriteLine("stack bomboş !");
                return -1;
            }else{
                int sayi = top.data;
                top = top.next;
                System.Console.WriteLine(sayi + " stack den çıkarıldı ! ");
                return sayi;
            }

        }
        public void push(int data){
            Node eleaman = new Node(data);

            if(top == null){
                top = eleaman;
                System.Console.WriteLine("Stack yapısı oluşturuldu ilk eleman eklendi !");
            }else{
                eleaman.next = top;
                top = eleaman;
                System.Console.WriteLine("eleman eklendi !");
            }


        }

        public void print(){
            if(top == null){
                System.Console.WriteLine("Stack boş !");
            }else {
                Node temp = top;
                
                System.Console.Write("\nüst ");
                while(temp != null){
                    System.Console.Write(temp.data+ " -> ");
                    temp = temp.next;
                }
                System.Console.WriteLine(" alt");
            }

        }
    }
}