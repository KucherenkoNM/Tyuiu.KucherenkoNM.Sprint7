using System.Windows.Forms;

namespace Tyuiu.KucherenkoNM.Sprint7.Project.V12
{
    public static class UiNotifier
    {
        public static void ShowLoaded()
        {
            MessageBox.Show(
                "Данные успешно загружены",
                "Загрузка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static void ShowSaved()
        {
            MessageBox.Show(
                "Данные успешно сохранены",
                "Сохранение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static void ShowRefreshed()
        {
            MessageBox.Show(
                "Данные перезагружены",
                "Перезагрузка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
