import "bootstrap/dist/css/bootstrap.min.css"
import { Link } from "react-router-dom"

function Home() {

    return (
        <>
            <div className='container container-fluid d-flex justify-content-center p-5 gap-5'>
                <Link to="/Cards" className="btn btn-primary">
                    Kártyák
                </Link>
                <Link to="/Add" className="btn btn-primary">
                    Kártya Hozzáadás
                </Link>

            </div>

        </>
    )
}

export default Home
