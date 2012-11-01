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
	abstract class BasePage {

		protected enum ARROW{
			UP = 0,
			DOWN,
			RIGHT,
			LEFT,
		}

		/// <summary>
		/// スプライトでテキストを描画するためのフォント
		/// </summary>
		protected SpriteFont Pagefont = null;

		/// <summary>
		/// キーボードの状態
		/// </summary>
		protected static KeyboardState PagekeyState = Keyboard.GetState();

		/// <summary>
		/// 現在スペースキーを押しているか
		/// </summary>
		private static bool nowSpaceKeyPushed = false;

		/// <summary>
		/// 前回スペースキーを押しているか
		/// </summary>
		private static bool previousSpaceKeyPushed = false;

		/// <summary>
		/// 現在矢印キーを押しているか。（上、下、右、左）
		/// </summary>
		private static bool[] nowArrowKeyPushed = new bool[4] { false, false, false, false };

		/// <summary>
		/// 前回矢印キーを押しているか。（上、下、右、左）
		/// </summary>
		private static bool[] previousArrowKeyPushed = new bool[4] { false, false, false, false };

		/*メソッド*/

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="font"></param>
		public BasePage(SpriteFont font) {
			Pagefont = font;
		}


		/// <summary>
		/// 更新処理
		/// </summary>
		/// <returns>0:通常終了</returns>
		public virtual int UpData() {
			// キーボードの状態を取得
			PagekeyState = Keyboard.GetState();
			return 0; 
		}

		/// <summary>
		/// 描画処理
		/// </summary>
		/// <param name="spriteBatch"></param>
		public virtual void Draw(ref SpriteBatch spriteBatch){}

		/// <summary>
		/// 画像の読み込み
		/// </summary>
		public virtual void LoadGraph() { }
		public virtual void LoadGraph(Texture2D tex1, Texture2D tex2, Texture2D tex3) { }
		
		/// <summary>
		/// スペースキーが押された瞬間かどうかを判定
		/// </summary>
		/// <returns></returns>
		public static bool SpaceKeyPushed() {
			// 前回のスペースキーの押下状態を記憶
			previousSpaceKeyPushed = nowSpaceKeyPushed;

			// 現在のスペースキーの押下状態を記憶
			nowSpaceKeyPushed = PagekeyState.IsKeyDown(Keys.Space);

			// キーが押された瞬間ならカウントする
			if(nowSpaceKeyPushed && !previousSpaceKeyPushed) {
				return true;
			} else {
				return false;
			}
		}

		/// <summary>
		/// 矢印キーが押された瞬間かどうかを判断
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public bool ArrowKeyPushed(int num) {

			previousArrowKeyPushed[num] = nowArrowKeyPushed[num];

			switch(num) {
				case 0:
					nowArrowKeyPushed[0] = PagekeyState.IsKeyDown(Keys.Up);
					break;
				case 1:
					nowArrowKeyPushed[1] = PagekeyState.IsKeyDown(Keys.Down);
					break;
				case 2:
					nowArrowKeyPushed[2] = PagekeyState.IsKeyDown(Keys.Right);
					break;
				case 3:
					nowArrowKeyPushed[3] = PagekeyState.IsKeyDown(Keys.Left);
					break;
			}

			// キーが押された瞬間ならカウントする
			if(nowArrowKeyPushed[num] && !previousArrowKeyPushed[num]) {
				return true;
			} else {
				return false;
			}
		}

	}
}
