#ifndef MYHLSLINCLUDE_INCLUDED
#define MYHLSLINCLUDE_INCLUDED

void RadialBlur_float(
    float2 UV,          // 接続：UVノード
    float Samples,      // 接続：5くらい
    float BlurStrengthX = 0.02, // 横方向の拡大率ステップ
    float BlurStrengthY = 0.05, // 縦方向の拡大率ステップ
    float2 Center,      // 中心座標
    float NoiseValue,   // 接続：上部1/5マスク済みノイズ float
    out float Result    // 出力
)
{
    int count = max(1, (int)Samples);
    float sum = 0;

    for(int i = 0; i < count; i++)
    {
        // 1ステップごとの拡大率
        float scaleX = 1.0 + BlurStrengthX * i;
        float scaleY = 1.0 + BlurStrengthY * i;

        // UV を中心に向かって拡大
        float2 sampleUV = (UV - Center) * float2(scaleX, scaleY) + Center;

        // 今回は外から渡されたノイズをそのまま使う
        // sampleUV に対応する値があればここで参照する形になるが
        // 今はシンプルに NoiseValue をそのまま足す
        sum += NoiseValue; 
    }

    Result = sum / count; // 平均
}

#endif
