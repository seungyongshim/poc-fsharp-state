namespace ConsoleApp1

type State<'S, 'A> = | State of state : 'S * action : 'A
type Random<'A> = State<int, 'A>

module StateModule = 
    
