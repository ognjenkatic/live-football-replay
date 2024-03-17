/* eslint-disable react/prop-types */
//function Result() {
//  return (
//    <p>Hello world!</p>
//  );
//}
const Result = ({ data }) => {
    if (!data) return;
    let keys = Object.keys(data);

    if (keys.length < 2) return;


    let home = keys[0];
    let away = keys[1];
    return <div>

        <div>
            <div className="result-display">
                <span className="home-team-display">{home} {data[home]?.goals ?? 0}</span>-
                <span className="away-team-display" >{data[away]?.goals ?? 0} {away}</span>
            </div>
        </div>


    </div>
}

export default Result;