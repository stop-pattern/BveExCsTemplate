﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BveEx.PluginHost.Plugins;

namespace BveExCsTemplate.VehiclePlugin
{
    /// <summary>
    /// プラグインの本体
    /// Plugin() の第一引数でこのプラグインの仕様を指定
    /// Plugin() の第二引数でこのプラグインが必要とするBveEx本体の最低バージョンを指定（オプション）
    /// </summary>
    [Plugin(PluginType.VehiclePlugin)]
    internal class VehiclePluginMain : AssemblyPluginBase
    {
        /// <summary>
        /// プラグインが読み込まれた時に呼ばれる
        /// 初期化を実装する
        /// </summary>
        /// <param name="builder"></param>
        public VehiclePluginMain(PluginBuilder builder) : base(builder)
        {
        }

        /// <summary>
        /// プラグインが解放されたときに呼ばれる
        /// BveEx
        /// </summary>
        public override void Dispose()
        {
        }

        /// <summary>
        /// シナリオ読み込み中に毎フレーム呼び出される
        /// </summary>
        /// <param name="elapsed">前回フレームからの経過時間</param>
        public override void Tick(TimeSpan elapsed)
        {
            // 処理を実装
        }
    }
}
