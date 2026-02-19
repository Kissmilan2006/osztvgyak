import { Link } from "react-router-dom";
function Home() {


    return (
        <>
            <Link to="/cards" className="btn btn-primary">
                Kártyák
            </Link>
            <Link to="/addcard" className="btn btn-primary">
                Hozzá adás
            </Link>
        </>
    )
}

export default Home
