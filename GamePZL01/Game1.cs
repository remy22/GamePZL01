using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GamePZL01 {
	/// <summary>
	/// 基底 Game クラスから派生した、ゲームのメイン クラスです。
	/// </summary>
	public class Game1 : Microsoft.Xna.Framework.Game {

		/*フィールド*/

		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		/// <summary>
		/// 現在のステージ番号
		/// </summary>
		private int numStage = 0;

		/// <summary>
		/// Pageクラス
		/// </summary>
		private BasePage[] Page = new BasePage[2];

		/// <summary>
		/// ゲームの終了フラグ
		/// </summary>
		private bool flagEndGame = false;


		/*メソッド*/

		public Game1() {
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

			//画面サイズ設定
			this.graphics.PreferredBackBufferWidth = 800;
			this.graphics.PreferredBackBufferHeight = 600;

			//マウスを可視化
			this.IsMouseVisible = true;
		}

		/// <summary>
		/// ゲームが実行を開始する前に必要な初期化を行います。
		/// ここで、必要なサービスを照会して、関連するグラフィック以外のコンテンツを
		/// 読み込むことができます。base.Initialize を呼び出すと、使用するすべての
		/// コンポーネントが列挙されるとともに、初期化されます。
		/// </summary>
		protected override void Initialize() {
			// TODO: ここに初期化ロジックを追加します。

			base.Initialize();
		}

		/// <summary>
		/// LoadContent はゲームごとに 1 回呼び出され、ここですべてのコンテンツを
		/// 読み込みます。
		/// </summary>
		protected override void LoadContent() {
			// 新規の SpriteBatch を作成します。これはテクスチャーの描画に使用できます。
			spriteBatch = new SpriteBatch(GraphicsDevice);

			// フォントをコンテンツパイプラインから読み込む
			Page[0] = new TitlePage(this.Content.Load<SpriteFont>("Font1"));
			Page[1] = new MainPage(this.Content.Load<SpriteFont>("Font1"));

			// TODO: this.Content クラスを使用して、ゲームのコンテンツを読み込みます。
		}

		/// <summary>
		/// UnloadContent はゲームごとに 1 回呼び出され、ここですべてのコンテンツを
		/// アンロードします。
		/// </summary>
		protected override void UnloadContent() {
			// TODO: ここで ContentManager 以外のすべてのコンテンツをアンロードします。
		}

		/// <summary>
		/// ワールドの更新、衝突判定、入力値の取得、オーディオの再生などの
		/// ゲーム ロジックを、実行します。
		/// </summary>
		/// <param name="gameTime">ゲームの瞬間的なタイミング情報</param>
		protected override void Update(GameTime gameTime) {
			// ゲームの終了条件をチェックします。
			if(GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || this.flagEndGame == true)　this.Exit();

			// TODO: ここにゲームのアップデート ロジックを追加します。
			int num = 0; 

			switch(this.numStage) {
				case 0:
					num = Page[0].UpData();
					switch(num){
						case 0:
							//通常終了
							break;
						case 1:
							//次のページ
							this.numStage++;
							break;
						case 2:
							//終了
							this.flagEndGame = true;
							break;
					}

					break;
				case 1:
					num = Page[1].UpData();
					switch(num) {
						case 0:
							//通常終了
							break;
						case 1:
							//次のページ
							this.numStage--;
							break;
					}
					break;
				default:
					//エラー
					break;
			}			



			base.Update(gameTime);
		}


		/// <summary>
		/// ゲームが自身を描画するためのメソッドです。
		/// </summary>
		/// <param name="gameTime">ゲームの瞬間的なタイミング情報</param>
		protected override void Draw(GameTime gameTime) {
			GraphicsDevice.Clear(Color.Black);

			// TODO: ここに描画コードを追加します。
			this.spriteBatch.Begin();

			switch(this.numStage) {
				case 0:
					Page[0].Draw(ref this.spriteBatch);
					break;
				case 1:
					Page[1].Draw(ref this.spriteBatch);
					break;
			}


			this.spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}
