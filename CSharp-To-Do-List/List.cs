class List{
    private int index;
    private string item;
    public string[] list;

    public List(){
        index = 0;
        item = "";
        list = new string[10];
    }

    public void addItem(int index, string item){
        this.item = item;
        this.index = index;
        this.list[this.index] = this.item;
        for(int i = index+1; i < list.Length; i++){
            list[i] = null;
        }
    }

    public string getItem(int index){
        return list[index];
    }

    public void editItem(int index, string item){
        this.list[index] = item;
        System.Console.WriteLine("Your new item in " + index+1 + " is " + item);
        System.Console.WriteLine("\n");
        
    }

    public void getList(){
        for(int i = 0; i < list.Length; i++){
            if(list[i] != null){
                System.Console.WriteLine(i+1 + ". " + list[i]);
            }
        }
    }

    public void completeItem(int index){
        list[index] = item + "(Complete)";
    }

}