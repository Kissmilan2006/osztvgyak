import { Link } from "react-router-dom";
function Home() {


    return (
        <>
            <Link to="/cards" className="btn btn-primary">
                Kártyák
            </Link>
        </>
    )
}

export default Home
