using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GamePZL01 {
	abstract class BaseObject {

		private double x = 0.0f;
		public double X {
			get { return x; }
			set { x = value; }
		}
		private double y = 0.0f;
		public double Y {
			get { return y; }
			set { y = value; }
		}



		/// <summary>
		/// 更新処理
		/// </summary>
		/// <returns>0:通常終了</returns>
		public virtual void UpData() {
		}

		/// <summary>
		/// 描画処理
		/// </summary>
		/// <param name="spriteBatch"></param>
		public virtual void Draw(ref SpriteBatch spriteBatch) { }

		/// <summary>
		/// 画像の読み込み
		/// </summary>
		public virtual void LoadGraph(Texture2D Tex) { }
	}
}
