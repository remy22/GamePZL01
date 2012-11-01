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
	class TitlePage : BasePage {

		/*フィールド*/

		/// <summary>
		/// 現在指しているカーソルの位置
		/// </summary>
		private int numCursor = 0;


		/*メソッド*/

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="font"></param>
		public TitlePage(SpriteFont font) : base(font){}

		/// <summary>
		/// 更新処理
		/// </summary>
		public override int UpData() {
			base.UpData();

			//カーソルの上下移動
			if(ArrowKeyPushed((int)ARROW.UP)){
				if(numCursor == 0) numCursor = 1;
				else numCursor--;
			}else if(ArrowKeyPushed((int)ARROW.DOWN)){
				if(numCursor == 1) numCursor = 0;
				else numCursor++;
			}

			//決定時の処理
			if(ArrowKeyPushed((int)ARROW.RIGHT)) {
				switch(numCursor) {
					case 0:
						return 1;
					case 1:
						return 2;
				}
			}

			return 0;
			
		}

		/// <summary>
		/// 描画処理
		/// </summary>
		/// <param name="spriteBatch"></param>
		public override void Draw(ref SpriteBatch spriteBatch) {
			spriteBatch.DrawString(this.Pagefont, "GameTitle", Vector2.Zero, Color.White);

			spriteBatch.DrawString(this.Pagefont, ">", new Vector2(680, 550 + (this.numCursor * 20)), Color.White);

			spriteBatch.DrawString(this.Pagefont, "Start", new Vector2(700, 550), Color.White);
			spriteBatch.DrawString(this.Pagefont, "END", new Vector2(700, 570), Color.White);


		}

		/// <summary>
		/// 画像の読み込み
		/// </summary>
		public override void LoadGraph() {
		}

		public override void LoadGraph(Texture2D tex1, Texture2D tex2, Texture2D tex3) { 
		}

	}
}
