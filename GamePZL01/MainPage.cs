﻿using System;
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




			if(SpaceKeyPushed()) {
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
		}


	}
}
