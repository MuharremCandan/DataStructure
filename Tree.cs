namespace DataStructure
{
    public class Tree
    {
        public NodeTree? root;
        
        public Tree()
        {
            root = null;
        }

        public NodeTree newNode(int data){
            root = new NodeTree(data);
            return root;
        }
        public NodeTree insert( NodeTree root, int data){

            NodeTree eleman = new NodeTree(data);
            if(root != null){
                if(data < root.data){
                root.left = insert(root.left, data);
                }else{
                root.right = insert(root.right, data);
                }
            }else{
                root = newNode(data);
            }
            return root;

            

        }
        public void preOrder(NodeTree root){ // önce köke uğra -> sonra sol ->  sonra sağ

            if(root != null){
                System.Console.Write(root.data + "  ");
                preOrder(root.left);
                preOrder(root.right);
            }

        }
         public void inOrder(NodeTree root){ // önce sola uğra  -> sonra kök ->  sonra sağ

            if(root != null){
               
                inOrder(root.left);
                System.Console.Write(root.data + "  ");
                inOrder(root.right);
            }
        }
         public void postOrder(NodeTree root){ //en son köke uğra

            if(root != null){           
                postOrder(root.left);    
                postOrder(root.right);
                System.Console.Write(root.data + "  ");
            }

        }

        public int size(NodeTree root){
            if(root == null){
                return 0;
            }else{
                return size(root.left)+ 1 + size(root.right);
            }
        }
        public int yukseklik(NodeTree root){

            if(root == null){
                return -1;
            }else{
                int right = yukseklik(root.right);
                int left = yukseklik(root.left);

                if(right < left)
                    return left+1;
                else    
                    return right+1;
            }
        }
        public void min(NodeTree root){
            if(root == null){
                System.Console.WriteLine("ağaç boş !");
            }else{
                NodeTree temp = root;
                while(temp.left != null){
                    temp = temp.left;
                }
                System.Console.WriteLine("Min value: "+ temp.data);
            }
            

        }
        public void max(NodeTree root){
            if(root == null){
                System.Console.WriteLine("The tree is empty !");
            }else{
                NodeTree temp = root;

                while(temp.right != null){
                    temp= temp.right;
                }
                System.Console.WriteLine("Max value : "+ temp.data);
            }
        }
    }
    public class NodeTree{

        public int data;
        public NodeTree? right ;
        public NodeTree? left;

        public NodeTree(int data)
        {
            this.data = data;
            right = null;
            left = null;
        }
    }
}