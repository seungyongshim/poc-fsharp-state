namespace ConsoleApp1

open System

type State<'S, 'A> = (struct ('S * 'A))
type Random = State<double, double>

module State =
    let map
    let random (seed : double) : Random = 
        let nextSeed = (1839567234. * seed + 972348567.) % 8239451023.
        (nextSeed, nextSeed)
    let randomInRange (max: double) (min: double) : Random =
        let inRange num =
            min + Math.Floor((num / 8239451023.) * (max - min))
        map inRange random
