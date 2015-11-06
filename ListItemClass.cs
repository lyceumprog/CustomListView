using System;
// ШАБЛОН ИНФОРМАЦИИ, КОТОРАЯ БУДЕТ СОДЕРЖАТЬ В СЕБЕ ДАННЫЕ ЯЧЕЙКИ
namespace CustomListView
{
	public class ListItemClass
	{
		public string tv1; // ДАННЫЕ ПЕРВОГО ПОЛЯ
		public string tv2; // ДАННЫЕ ВТОРОГО ПОЛЯ
		public int iv;	   // ДАННЫЕ КАРТИНКИ

		public ListItemClass (string tv1, string tv2, int iv) // КОНСТРУКТОР
		{
			this.tv1 = tv1;
			this.tv2 = tv2;
			this.iv = iv;
		}
	}
}

