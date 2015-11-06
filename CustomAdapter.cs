using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//#########################  ФАЙЛ ПЕРЕОПРЕДЕЛЕНИЯ КЛАССА ADAPTER, ДЛЯ ТОГО, ЧТОБЫ КОНВЕРТАЦИЯ ИЗ ИНФОРМАЦИИ В ЯЧЕЙКУ ПРОИСХОДИЛО УСПЕШНО
namespace CustomListView
{
	public class CustomAdapter : BaseAdapter<ListItemClass>
	{
		Activity context;
		List<ListItemClass> items; // ПЕРЕДЕННЫЕ ДАННЫЕ ДЛЯ РАЗМЕЩЕНИЯ НА ИНТЕРФЕЙСЕ

		public CustomAdapter (Activity context, List<ListItemClass> items) : base() // БАЗОВЫЙ КОНСТРУКТОР, НАСЛЕДОВАННЫЙ ОТ РОДИТЕЛЯ
		{
			this.context = context;
			this.items = items;
		}
		public override long GetItemId(int position) // ПЕРЕОПРЕДЕЛЕНИЕ ФУНКЦИИ ПОЛУЧЕНИЯ ТЕКУЩЕГО ЭЛЕМЕНТА
		{
			return position;
		}
		public override ListItemClass this[int position] // ПЕРЕОПРЕДЕЛЕНИЕ ФУНКЦИИ ПОЛУЧЕНИЯ ИНФОРМАЦИИ О ТЕКУЩЕМ ЭЛЕМЕНТЕ
		{
			get { return items[position]; }
		}
		public override int Count // ПЕРЕОПРЕДЕЛЕНИЕ ФУНКЦИИ ПОЛУЧЕНИЯ КОЛИЧЕСТВА ЭЛЕМЕНТОВ
		{
			get { return items.Count; }
		}
		public override View GetView(int position, View convertView, ViewGroup parent) // ПЕРЕОПРЕДЕЛЕНИЕ ФУНКЦИИ СОЗДАНИЯ И ПОЛУЧЕНИЯ СОЗДАННЫХ РАНЕЕ ЯЧЕЕК
		{
			var item = items[position];

			View view = convertView;
			if (view == null) // ЕСЛИ ЯЧЕЙКА НЕ БЫЛА СОЗДАНА
				view = context.LayoutInflater.Inflate(Resource.Layout.CustomListItem, null); // СОЗДАЕМ ЯЧЕЙКУ ПО ШАБЛОНУ

			view.FindViewById<TextView> (Resource.Id.textView1).Text = item.tv1; // ПОЛУЧАЕМ ДОСТУП К ТЕКСТОВОМУ ПОЛЮ 1 И ИЗМЕНЯЕМ ТЕКСТ
			view.FindViewById<TextView> (Resource.Id.textView2).Text = item.tv2; // ПОЛУЧАЕМ ДОСТУП К ТЕКСТОВОМУ ПОЛЮ 2 И ИЗМЕНЯЕМ ТЕКСТ
			view.FindViewById<ImageView> (Resource.Id.imageView1).SetBackgroundResource (item.iv); // ПОЛУЧАЕМ ДОСТУП К ПОЛЮ КАРТИНКИ И ИЗМЕНЯЕМ ЕГО

			return view;
		}
	}
}

