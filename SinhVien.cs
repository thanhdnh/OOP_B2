public class SinhVien{
    //Khai báo fields
    private string id;
    private string hoten;
    private byte tuoi;
    //Hàm tạo Constructor
    public SinhVien(string myid, string myhoten, byte mytuoi){
        id = myid;
        hoten = myhoten;
        tuoi = mytuoi;
    }
    public SinhVien(SinhVien c){
        id = c.id;
        hoten = c.hoten;
        tuoi = c.tuoi;
    }
    //Khai báo các Properties
    public void setID(string myid){id = myid;}
    public string getID(){return id;}
    public void setHoTen(string myhoten){hoten=myhoten;}
    public string getHoTen(){return hoten;}
    public void setTuoi(byte mytuoi){tuoi=mytuoi;}
    public byte getTuoi(){return tuoi;}

    //Khai báo các methods
    //Khai báo các events
}