

namespace App1
{
    public class MainViewModel : Observable
    {
        private MyTypeEnum _myTypeEnum = MyTypeEnum.Type1;

        public MyTypeEnum MyTypeEnum
        {
            get => _myTypeEnum;
            set => Set(ref _myTypeEnum, value);
        }
    }
}
