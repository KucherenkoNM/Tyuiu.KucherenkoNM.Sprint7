namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12.Lib.Services
{
    public interface IEditableData
    {
        void SetData(DataManager manager);
        void Load(string path);
        void Save(string path);
        void RefreshData();
    }
}
