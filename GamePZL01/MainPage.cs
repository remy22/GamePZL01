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
	class MainPage : BasePage {

		/*フィールド*/
		private BaseObject ber = new Ber();
		private BaseObject ball = new Ball();
		private BaseObject block = new Block();


		/*メソッド*/

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="font"></param>
		public MainPage(SpriteFont font) : base(font) {}

		/// <summary>
		/// 更新処理
		/// </summary>
		public override int UpData() {
			base.UpData();

			if(PagekeyState.IsKeyDown(Keys.Right)) ber.X+=3.5;
			if(PagekeyState.IsKeyDown(Keys.Left)) ber.X-=3.5;


			if(PagekeyState.IsKeyDown(Keys.Escape)) {
				return 1;
			} else {
				return 0;
			}
		}

		/// <summary>
		/// 描画処理
		/// </summary>
		/// <param name="spriteBatch"></param>
		public override void Draw(ref SpriteBatch spriteBatch) {
			spriteBatch.DrawString(this.Pagefont, "GameMain", Vector2.Zero, Color.White);

			ber.Draw(ref spriteBatch);
			ball.Draw(ref spriteBatch);
			block.Draw(ref spriteBatch);
		}

		public override void LoadGraph() {
		}

		public override void LoadGraph(Texture2D tex1, Texture2D tex2, Texture2D tex3) {
			ber.LoadGraph(tex1);
			ball.LoadGraph(tex2);
			block.LoadGraph(tex3);
		}

	}
}
