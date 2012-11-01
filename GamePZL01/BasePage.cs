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

		/*フィールド*/

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


	}
}
