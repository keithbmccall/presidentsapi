import React, { Component } from "react";

const President = props => {
  const { president } = props;
  return (
    <div>
      <h5>{president.name}</h5>
      <div>{president.pob} {president.dob} — {president.pod} {president.dod}</div>
    </div>
  );
};

export default President;
