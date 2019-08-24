#region Header
//   Vorspire    _,-'/-'/  GridPool.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2018  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
#endregion

namespace VitaNex.Collections
{
	public sealed class GridPool<T> : ObjectPool<Grid<T>>
	{
		public GridPool()
		{ }

		public GridPool(int capacity)
			: base(capacity)
		{ }

		public override void Free(Grid<T> o)
		{
			if (o != null)
			{
				o.Resize(0, 0);
			}

			base.Free(o);
		}
	}
}