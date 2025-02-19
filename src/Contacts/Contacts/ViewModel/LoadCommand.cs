using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация команды загрузки.
    /// </summary>
    internal class LoadCommand : ICommand
    {
        /// <summary>
        /// Поле, содержащее делегат Action, который будет выполнен при вызове команды.
        /// Делегат принимает параметр типа object?, 
        /// который может быть использован для передачи данных в команду.
        /// </summary>
        private readonly Action<object?> _execute;

        /// <summary>
        /// Метод, реализующий интерфейс ICommand. 
        /// Выполняет делегат Action, переданный в конструкторе.
        /// </summary>
        /// <param name="parameter">Параметр, передаваемый в команду из View. Может быть null, если параметр не требуется.</param>
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
        /// <summary>
        /// Метод, реализующий интерфейс ICommand. 
        /// Определяет, может ли команда быть выполнена в текущем состоянии приложения.
        /// </summary>
        /// <param name="parameter">
        /// Параметр, передаваемый в команду из View. 
        /// Используется для определения возможности выполнения команды.
        /// </param>
        /// <returns>Возвращает true, так как команда всегда может быть выполнена.</returns>
        public bool CanExecute(object? parameter) => true;

        /// <summary>
        /// Событие, реализующее интерфейс ICommand. 
        /// Уведомляет элементы управления, привязанные к команде, 
        /// об изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="execute">Делегат Action, который будет выполнен при вызове команды.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если переданный делегат execute равен null.</exception>
        public LoadCommand(Action<object?> execute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }
    }
}
