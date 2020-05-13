// ref: https://www.codewars.com/kata/515e188a311df01cba000003

object GetPlanetName {
    def get_planet_name(id: Int): String = id match {
        case 1 => "Mercury"
        case 2 => "Venus"
        case 3 => "Earth"
        case 4 => "Mars"
        case 5 => "Jupiter"
        case 6 => "Saturn"
        case 7 => "Uranus"
        case 8 => "Neptune"
        case _ => "UNDEFINED"
    }
}