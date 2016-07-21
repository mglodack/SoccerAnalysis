namespace SoccerAnalysis

// 2015/2016 Season
// English Premier League
module TeamMapping =

  type Team =
    | AfcBournemouth
    | Arsenal
    | Chelsea
    | CrystalPalace
    | Everton
    | LeicesterCity
    | Liverpool
    | ManchesterCity
    | ManchesterUnited
    | Southampton
    | StokeCity
    | Sunderland
    | SwanseaCity
    | TottenhamHotspur
    | Watford
    | WestBromwichAlbion
    | WestHamUnited
    | NorwichCity
    | AstonVilla
    | NewcastleUnited

  let getTeamFromAbbreviation abbreviation =
    match abbreviation with
    | "NEW" -> Some AfcBournemouth
    | "STK" -> Some StokeCity
    | "NOR" -> Some NorwichCity
    | "AVL" -> Some AstonVilla
    | "MCI" -> Some ManchesterCity
    | "SWA" -> Some SwanseaCity
    | "CHE" -> Some Chelsea
    | "LEI" -> Some LeicesterCity
    | "SUN" -> Some Sunderland
    | "MUN" -> Some ManchesterUnited
    | "WHU" -> Some WestHamUnited
    | "WBA" -> Some WestBromwichAlbion
    | "WAT" -> Some Watford
    | "BOU" -> Some AfcBournemouth
    | "CRY" -> Some CrystalPalace
    | "LIV" -> Some Liverpool
    | "EVE" -> Some Everton
    | "ARS" -> Some Arsenal
    | "SOU" -> Some Southampton
    | "TOT" -> Some TottenhamHotspur
    | _ -> None

  let getTeamName team =
    match team with
    | AfcBournemouth      -> "AFC Bournemouth"
    | Arsenal             -> "Arsenal"
    | Chelsea             -> "Chelsea"
    | CrystalPalace       -> "Crystal Palace"
    | Everton             -> "Everton"
    | LeicesterCity       -> "Leicester City"
    | Liverpool           -> "Liverpool"
    | ManchesterCity      -> "Manchester City"
    | ManchesterUnited    -> "Manchester United"
    | Southampton         -> "Southampton"
    | StokeCity           -> "Stoke City"
    | Sunderland          -> "Sunderland"
    | SwanseaCity         -> "Swansea City"
    | TottenhamHotspur    -> "Tottenham Hotspur"
    | Watford             -> "Watford"
    | WestBromwichAlbion  -> "West Bromwich Albion"
    | WestHamUnited       -> "West Ham United"
    | NorwichCity         -> "Norwich City"
    | AstonVilla          -> "Aston Villa"
    | NewcastleUnited     -> "Newcastle United"
