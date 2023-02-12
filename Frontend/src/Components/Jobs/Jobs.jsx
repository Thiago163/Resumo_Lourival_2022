import React from 'react'
import JobCard from '../Cards/JobCard'
import { useEffect, useState } from "react";

function Jobs() {

  const [usuarios, setUsuarios] = useState([]);

  useEffect(() => {
    fetch("https://localhost:44368/api/Usuario", {
      method: "GET",
    })
      .then((response) => response.json())
      .then((json) => {
        setUsuarios(json);
      })
      .catch((error) => {
        console.log(error);
        alert("Erro ao buscar Usuario");
      });
  }, []);

  return (
    <div className='jobs-area'>
      {
        usuarios.map((usuario, index) => (
          <JobCard usuario={usuario} key={index} />
        ))
      }
    </div>
  )
}

export default Jobs;