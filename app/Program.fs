module Program

open Feliz
open Browser.Dom

ReactDOM.render(
    App.Render(),
    document.getElementById "feliz-app"
)