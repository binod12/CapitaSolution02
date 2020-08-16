using Microsoft.ML.Data;

namespace OnnxObjectDetection
{
    public class TinyYoloPrediction : IOnnxObjectPrediction
    {
        [ColumnName("model_outputs0")]
        public float[] PredictedLabels { get; set; }
    }
}
