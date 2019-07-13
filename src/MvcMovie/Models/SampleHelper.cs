using System.Linq;

namespace MvcMovie.Models
{
    public static class SampleHelper
    {
        public static SamplePostParameterViewModel Sort(SamplePostParameterViewModel parameter)
        {
            // バブルソート
            // バブルソートの計算量はO(n^2)なので超非効率！
            for (var i = 0; i < parameter.Numbers.Count; i++)
            {
                for ( var j = i + 1; j < parameter.Numbers.Count; j++) {
                    if (parameter.Numbers[i] > parameter.Numbers[j]) {
                        var tmp = parameter.Numbers[i];
                        parameter.Numbers[i] = parameter.Numbers[j];
                        parameter.Numbers[j] = tmp;
                    }
                }
            }

            return parameter;
        }

        public static SamplePostParameterViewModel SortDescending(SamplePostParameterViewModel parameter)
        {
            // バブルソート
            // バブルソートの計算量はO(n^2)なので超非効率！
            for (var i = 0; i < parameter.Numbers.Count; i++)
            {
                for ( var j = i + 1; j < parameter.Numbers.Count; j++) {
                    if (parameter.Numbers[i] > parameter.Numbers[j]) {
                        var tmp = parameter.Numbers[i];
                        parameter.Numbers[i] = parameter.Numbers[j];
                        parameter.Numbers[j] = tmp;
                    }
                }
            }

            return parameter;
        }

        public static bool Exist(SamplePostParameterViewModel parameter)
        {
            // TODO: 処理がないのでテストコードが通るように処理を書きましょう
            return true;
        }

        // TODO: 値のリストを受け取って最大値を返却するメソッドを定義してみましょう

        // TODO: 受け取った数値分のフィボナッチ数をすべて返すメソッドを定義してみましょう
        // 例えば「5」を受け取った場合に返却される値は「0, 1, 1, 2, 3」です。
        // 「10」を受け取った場合は「0, 1, 1, 2, 3, 5, 8, 13, 21, 34」です。

    }
}