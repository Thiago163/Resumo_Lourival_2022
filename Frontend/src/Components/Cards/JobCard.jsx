import "./JobCard.css";

function JobCard({ usuario }) {
    return (
            <div className='card'>
                <div className="text-area">
                        <h1>{usuario.nome}</h1>
                        <h2>{usuario.email}</h2>
                </div>
            </div>
    )
}

export default JobCard