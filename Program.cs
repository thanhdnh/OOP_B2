public class Program
{
    public static void Main(string[] args)
    {
        SinhVien sv = new SinhVien("SV001", "Nguyen A", 20);
        //sv.setID("SV001");
        //sv.setHoTen("Nguyen A");
        //sv.setTuoi(20);
        Console.WriteLine($"Sinh vien(ID=>{sv.getID()}, HoTen=>{sv.getHoTen()}, Tuoi=>{sv.getTuoi()})");
        SinhVien sv2 = new SinhVien(sv);
        sv2.setHoTen("Le B");
        Console.WriteLine($"Sinh vien(ID=>{sv.getID()}, HoTen=>{sv.getHoTen()}, Tuoi=>{sv.getTuoi()})");
        Console.ReadLine();
    }
}