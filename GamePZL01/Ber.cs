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
	class Ber : BaseObject{

		/*フィールド*/

		/// <summary>
		/// バーの画像
		/// </summary>
		static private Texture2D TextureBer = null;


		/*メソッド*/

		public override void UpData() {
		}

		public override void Draw(ref SpriteBatch spriteBatch) {
			Vector2 pos = new Vector2((int)X, (int)Y);
			spriteBatch.Draw(TextureBer, pos, Color.GreenYellow);
		}

		public override void LoadGraph(Texture2D Tex) {
			TextureBer = Tex;
		}

	}
}
